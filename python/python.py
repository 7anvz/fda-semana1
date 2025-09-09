def main():
 num1 = int(input("INGRESE NUMERO 1: "))
 num2 = int(input("INGRESE NUMERO 1: "))
 division = float(num1 / num2)
 print(f"LA SUMA ES {num1 + num2}")
 print(f"LA RESTA ES {num1 - num2}")
 print(f"LA MULTIPLICACION ES {num1 * num2}")
 print(f"LA DIVISION ES {division}")

import math 
def ejer04():
  num = float(input("INGRESE NUMERO DECIMAL"));
  raiz = math.sqrt(num)
  redo = round(num, 2)
  cubo = math.pow(num, 3)
  cubica = num ** (1/3)
  print(f"LA RAIZ CUADRADA ES: {raiz}");
  print(f"REDONDEADO ES: {redo}");
  print(f"ELEVADO AL CUBO ES: {cubo}");
  print(f"LA RAIZ CUBICA ES: {cubica}");