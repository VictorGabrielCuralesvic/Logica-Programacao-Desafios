def calcular_imposto(salario):
    imposto = 0.00
    if (salario >= 0 and salario <= 11000):
        imposto = 0.05
    elif (salario >= 1100 and salario <= 2500):
        imposto = 0.10
    else:
        imposto = 0.15
    return imposto * salario

valor_salario = float(input())
valor_beneficio = float(input())

valor_imposto = calcular_imposto(valor_salario)
saida = (valor_salario - valor_imposto) + valor_beneficio
print(f'{saida: .2f}')
