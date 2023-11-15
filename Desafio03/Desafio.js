const valorSalario = parseFloat(gets());
const valorBeneficios = parseFloat(gets());

const valorImposto = calcularImposto(valorSalario);
const saida = (valorSalario - valorImposto) + valorBeneficios;
print(saida.toFixed(2));

function calcularImposto(salario) {
    let imposto;
    
    if (salario >= 0 && salario <= 1100) {
        imposto = 0.05;
    } else if (salario >= 1100 && salario <= 2500) {
        imposto = 0.10; 
    } else {
        imposto = 0.15;
    }

    return imposto * salario;
}