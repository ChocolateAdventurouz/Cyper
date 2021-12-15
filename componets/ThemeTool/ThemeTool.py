"""
################################################################
Cyper -- Registry for Themes

Coded by: SecurityRaven
################################################################
"""

# Importing modules
import winreg
import sys
from sys import exit
sys.setrecursionlimit(10000)
from_main_command_sent = sys.argv[1]

# Function to set the dark Theme
def dark():
    REG_PATH = r"SOFTWARE\Cyper"
    name = "Dark_Theme"
    value = "1"
    try:
        winreg.CreateKey(winreg.HKEY_CURRENT_USER, "SOFTWARE\Cyper")
        registry_key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, "SOFTWARE\Cyper", 1, 
                                       winreg.KEY_WRITE)
        winreg.SetValueEx(registry_key, "Light_Theme", 0, winreg.REG_DWORD, 0)      
        winreg.SetValueEx(registry_key, "Dark_Theme", 0, winreg.REG_DWORD, 1)
        winreg.CloseKey(registry_key)
        return True
    except WindowsError:
        return False

# Function to set the light theme
def light():
    REG_PATH = r"SOFTWARE\Cyper"
    name = "Light_Theme"
    value = "1"
    try:
        winreg.CreateKey(winreg.HKEY_CURRENT_USER, "SOFTWARE\Cyper")
        registry_key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, "SOFTWARE\Cyper", 1, 
                                       winreg.KEY_WRITE)
        winreg.SetValueEx(registry_key, "Dark_Theme", 0, winreg.REG_DWORD, 0)
        winreg.SetValueEx(registry_key, "Light_Theme", 0, winreg.REG_DWORD, 1)
        winreg.CloseKey(registry_key)
        return True
    except WindowsError:
        return False
if from_main_command_sent == "Dark":
    dark()
elif from_main_command_sent == "Light":
    light()
else:
    sys.exit("Invalid command sent")
