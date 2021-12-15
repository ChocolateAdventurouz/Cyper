try:
    import ctypes
    import requests
    import sys
    import hashlib
    from sys import exit
    sys.setrecursionlimit(10000)
except ImportError:
    print("ERROR: MODULE_MISSING")
    sys.exit(1)

try:
    filename = sys.argv[1]
except IndexError:
    print("ERROR: INPUT_INACESSIBLE")
    sys.exit(1)

try:
    db = requests.get ("https://bazaar.abuse.ch/export/txt/sha1/recent/")
except requests.ConnectionError:
    print("ERROR: DB_CONNECTION_FAILED")
    sys.exit(1)

except requests.ConnectionRefusedError:
    print("ERROR: DB_CONNECTION_REFUSED")
    sys.exit(1)
except requests.ConnectTimeout:
    print("ERROR: DB_CONNECTION_TIMEOUT")
    sys.exit(1)
def hash_file(filename):
    try:
        fe = open(filename, 'rb')
        fe.close()
    except FileNotFoundError or IOError:
        print("ERROR: FILE_NOT_FOUND")
        sys.exit(1)
    # make a hash object
    h = hashlib.sha1()

    # open file for reading in binary mode
    with open(filename,'rb') as file:

        # loop till the end of the file
        chunk = 0
        while chunk != b'':
            # read only 1024 bytes at a time
            chunk = file.read(1024)
            h.update(chunk)

    # return the hex representation of digest
    file.close()
    return h.hexdigest()

message = hash_file(filename)

if message in db:
    ctypes.windll.user32.MessageBoxW(0, "Threat Detected", "Cyper", 0)
    print ("Threat Detected")
    sys.exit()
else:
    ctypes.windll.user32.MessageBoxW(0, "No Threat Detected", "Cyper", 0)
    print ("No Threat Detected")
    sys.exit()