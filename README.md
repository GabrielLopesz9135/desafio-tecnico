# Desafio Técnico – Desenvolvedor de Sistemas Jr

## 📘 Sobre o Projeto

Este repositório contém a solução para um desafio técnico composto por três questões de lógica de programação, todas implementadas em C#, utilizando uma aplicação de console simples.

O objetivo é demonstrar **raciocínio lógico**, **organização** e **domínio básico da linguagem**, conforme solicitado para a vaga de Desenvolvedor de Sistemas Jr.

## 🛠 Tecnologias Utilizadas

*   C# (.NET 6+)
*   Console Application
*   Git & GitHub para versionamento

## 📁 Estrutura do Projeto

A estrutura do projeto está organizada da seguinte forma:

```
DesafioTecnico/
├── Program.cs
├── Questao1.cs
├── Questao2.cs
├── Questao3.cs
├── README.md
└── .gitignore
```

Cada arquivo representa uma questão separada.
A execução de cada uma é feita chamando o método `Executar()` dentro do `Program.cs`.

O arquivo `Program.cs` deve se parecer com o seguinte (para rodar a Questão 1):

```csharp
Questao1.Executar();
//Questao2.Executar();
//Questao3.Executar();
```

Basta comentar/descomentar conforme a questão que deseja rodar.

## 📚 Descrição das Questões

### 1️⃣ Questão 1 – Cálculo de Comissão

A partir de um JSON de vendas:

*   Lê o nome do vendedor e o valor das vendas.
*   Aplica as regras:
    *   `< R$100` → sem comissão
    *   `< R$500` → 1%
    *   `≥ R$500` → 5%
*   Soma e exibe a comissão total por vendedor.

### 2️⃣ Questão 2 – Movimentação de Estoque

Com base em um JSON contendo produtos:

*   Permite registrar entrada ou saída de estoque.
*   Cada movimentação possui:
    *   ID único
    *   Descrição
*   Atualiza o estoque e exibe o saldo final do produto movimentado.

### 3️⃣ Questão 3 – Cálculo de Juros por Atraso

Com base em um valor e data de vencimento:

*   Calcula quantos dias o pagamento está atrasado.
*   Por padrão, aplica juros simples de 2,5% ao dia.
*   O usuário pode optar por juros compostos.
*   Exibe o valor final atualizado.

## ▶️ Como Executar

### Pré-requisitos

Certifique-se de ter o **.NET** instalado. Você pode verificar a versão com o seguinte comando:

```bash
dotnet --version
```

Requer versão **6.0 ou superior**.

### Rodando o Projeto

1.  Navegue até o diretório do projeto no terminal:

    ```bash
    cd DesafioTecnico
    ```

2.  Execute o projeto:

    ```bash
    dotnet run
    ```

3.  Para escolher a questão a ser executada, edite o arquivo `Program.cs` e comente/descomente a chamada do método `Executar()` da questão desejada.

    Exemplo para rodar a Questão 2:

    ```csharp
    //Questao1.Executar();
    Questao2.Executar();
    //Questao3.Executar();
    ```

## 🎯 Objetivo

O projeto visa demonstrar:

*   Lógica de programação sólida
*   Separação simples de responsabilidades
*   Manipulação de dados e cálculos
*   Organização de código
*   Familiaridade com C# e estruturas básicas

## 👨‍💻 Autor

Desenvolvido por **Gabriel Lopes** como parte de um desafio técnico para processo seletivo.
