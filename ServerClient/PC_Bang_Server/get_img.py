from flask import Flask, request
from werkzeug.utils import secure_filename
import os

app = Flask(__name__)

# Directory where uploaded files will be stored
UPLOAD_FOLDER = 'public_html'
app.config['UPLOAD_FOLDER'] = UPLOAD_FOLDER

@app.route('/upload', methods=['POST'])
def file_upload():
    if 'file' not in request.files:
        return 'No file part in the request', 400

    file = request.files['file']

    if file.filename == '':
        return 'No selected file', 400

    if file:
        # You can add a file validation check here (file type, size, etc.)
        filename = secure_filename(file.filename)
        file.save(os.path.join(app.config['UPLOAD_FOLDER'], filename))
        return 'File successfully uploaded', 200

if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=15000)

