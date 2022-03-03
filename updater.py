from zipfile import ZipFile
from tqdm import tqdm
import time
import sys
import os
os.system("cls")
try:
    argument = sys.argv[1]
except IndexError:
    pass
except NameError:
    pass
pkg = "update/Q3lwZXIgVXBkYXRlIEZpbGVz.cupkg"
os.getcwd()
print("Cyper's Update Patch Installer [1.0.0]")

try: 
    if argument == "/u":

        # 32-bit
        if os.path.exists("C:/Program Files/Cyper"):
            for i in tqdm (range (100), desc="Updating..."):
                with ZipFile(pkg, 'r') as zip:
                    try: 
                        zip.extractall("C:/Program Files/Cyper")
                    except FileNotFoundError:
                        print("Error:0722")
                    except FileExistsError:
                        pass
                    finally:
                        print("Sucessfully Updated!")
                time.sleep(0.25)
        # 64-bit
        elif os.path.exists("C:/Program Files (x86)/Cyper"):
            for i in tqdm (range (100), desc="Updating..."):
                with ZipFile(pkg, 'r') as zip:
                    try: 
                        zip.extractall("C:/Program Files (x86)/Cyper")
                    except FileNotFoundError:
                        print("Error:0722")
                    except FileExistsError:
                        pass     
                        print("Sucessfully Updated!")
            time.sleep(0.25)
        else:
            print("Error: 0729")
    else:
        print("No input.")
except NameError:
    pass
    print("No input.")
    sys.exit()