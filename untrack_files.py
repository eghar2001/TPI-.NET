from os import system

with open("eliminar.txt", mode = "r") as archivo:
    for linea in archivo:
        if not linea.startswith("#"):
            system(f"git rm -r --cached {linea}")