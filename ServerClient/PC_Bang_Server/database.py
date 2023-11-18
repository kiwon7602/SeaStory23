import aiomysql

class Database:
    def __init__(self, loop, config):
        self.loop = loop
        self.config = config
        self.pool = None

    async def connect(self):
        # Create a pool of connections
        self.pool = await aiomysql.create_pool(loop=self.loop, **self.config)

    async def execute_query(self, query, params=None, commit=False):
        # Acquire a connection from the pool
        async with self.pool.acquire() as conn:
            async with conn.cursor() as cursor:
                await cursor.execute(query, params or ())
                if query.strip().upper().startswith("SELECT"):
                    return await cursor.fetchall()
                elif commit:
                    await conn.commit()

    async def fetch_one(self, query, params=None):
        # Acquire a connection from the pool
        async with self.pool.acquire() as conn:
            async with conn.cursor() as cursor:
                await cursor.execute(query, params or ())
                return await cursor.fetchone()

    async def close(self):
        # Close the pool of connections
        self.pool.close()
        await self.pool.wait_closed()

