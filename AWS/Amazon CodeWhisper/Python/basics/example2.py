# Function to upload a file to an S3 bucket

import boto3
import botocore
import os

s3 = boto3.client('s3')

def upload_file(file_name, bucket, object_name=None):
    # If S3 object_name was not specified, use file_name
    if object_name is None:
        object_name = os.path.basename(file_name)

    # Upload the file
    s3.upload_file(file_name, bucket, object_name)
    print("Upload Successful")
    return True
