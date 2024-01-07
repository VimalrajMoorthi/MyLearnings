import re
# function to verify email address

def verify_email(email):
    if re.match(r"^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$", email):
        return True
    else:
        return False
