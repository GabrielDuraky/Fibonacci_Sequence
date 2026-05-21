# Sequência de Fibonacci

## Descrição:
Algoritimo simples que recolhe o input do usuário como posição na sequência de Fibonacci.
O algoritmo foi escrito usando C# na versão .NET 8, usa a biblioteca Numerics para utilizar
o 'BigInteger' que aceita uma sequência com uma posição mais alta sem ocorrer overflow.

## Como testar:
### Opção 1 - GitHub Codespaces
1. Abra o repositório no GitHub
2. Clique em **Code** → **Codespaces** → **Create codespace on main**
3. No terminal, rode:
   ```bash
   dotnet run

### Opção 2 - Localmente
git clone https://github.com/GabrielDuraky/Fibonacci_Sequence.git
cd Fibonacci_Sequence
dotnet run

## Avisos Importantes

- O programa possui **limite máximo de 10.000** posições por segurança.
- **Não teste com valores muito altos** (acima de 200~300).  
  A sequência de Fibonacci cresce exponencialmente e imprimir milhares de números polui muito o console e dificulta a leitura.
- **Valores recomendados para demonstração:** `0`, `10`, `20`, `50`, `92`

O sistema é robusto e não quebra mesmo com valores altos, mas a experiência visual fica ruim.
