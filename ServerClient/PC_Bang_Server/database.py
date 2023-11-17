import aiomysql

class Database:
    def __init__(self, loop, config):
        self.loop = loop
        self.config = config

    async def connect(self):
        self.conn = await aiomysql.connect(loop=self.loop, **self.config)
        self.cursor = await self.conn.cursor()

    async def execute_query(self, query, params=None, commit=False):
        await self.cursor.execute(query, params or ())
        if query.strip().upper().startswith("SELECT"):
            return await self.cursor.fetchall()
        elif commit:
            await self.conn.commit()
    
    async def fetch_one(self, query, params=None):
        await self.cursor.execute(query, params or ())
        return await self.cursor.fetchone()

    async def close(self):
        await self.cursor.close()
        self.conn.close()
