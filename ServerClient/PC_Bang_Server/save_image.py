import base64
import os

async def save_image(data, directory="public_html/"):
    image_data = data.get("image")  # Assuming the image is sent as base64 string
    image_name = data.get("name", "default_image_name")  # Default name if not provided
    extension = data.get("extension")

    if not os.path.exists(directory):
        os.makedirs(directory)

    image_path = os.path.join(directory, f"{image_name}.{extension}")

    with open(image_path, "wb") as img_file:
        img_file.write(base64.b64decode(image_data))

    return image_path
