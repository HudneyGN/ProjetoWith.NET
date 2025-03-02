# Cadastro de Pessoas - Windows Forms & MySQL

## 📌 Sobre o Projeto
Este projeto é um sistema de Cadastro de Pessoas desenvolvido em **C# Windows Forms** com integração ao **MySQL**. Ele permite registrar, visualizar e gerenciar informações de usuários de maneira eficiente e intuitiva.

⚠️ **Este projeto está em desenvolvimento!** Futuras funcionalidades ainda serão definidas e implementadas.

![image](https://github.com/user-attachments/assets/8813825a-a05a-4e60-bf16-bf124da0c57a)![image](https://github.com/user-attachments/assets/2eefede7-6742-4607-b437-733e3f59b361)

📌 Novas implementações 📌
Criado classe Clear com o método Limpar Tela
![image](https://github.com/user-attachments/assets/ae4b447f-61c5-42ef-bd8a-911f8e6c1750)
![image](https://github.com/user-attachments/assets/76808485-6646-4d9f-af94-c52bbac5492c)

## 🚀 Funcionalidades Atuais
- Cadastro de pessoas com os seguintes campos:
  - Código (ID)
  - Nome
  - E-mail
  - RG
  - CPF
  - Sexo
  - Endereço (Rua, Número, Bairro, Cidade, Estado, UF)
- Interface gráfica amigável e de fácil navegação
- Banco de dados MySQL para armazenamento dos registros
- Operações básicas de **CRUD** (Create, Read, Update, Delete)
- Botões de **Cadastrar** e **Cancelar** para manipulação de dados

## 🔄 Funcionalidades Futuras
- Implementação de novas regras de negócio (a definir)
- Melhorias na interface gráfica
- Validações aprimoradas para os campos de entrada
- Outros recursos a serem planejados conforme o desenvolvimento avança

## 🛠️ Tecnologias Utilizadas
- **C# (Windows Forms)** - Para a construção da interface gráfica e lógica do sistema
- **MySQL** - Banco de dados para armazenar os registros
- **MySQL Workbench** - Para gerenciar e visualizar os dados

## 🎯 Estrutura do Banco de Dados
A tabela **PESSOA** é definida conforme o seguinte esquema:
```sql
CREATE TABLE PESSOA(
    ID INT PRIMARY KEY AUTO_INCREMENT,
    NOME VARCHAR(30),
    EMAIL VARCHAR(30),
    RG VARCHAR(30),
    CPF VARCHAR(10),
    SEXO VARCHAR(10),
    RUA VARCHAR(30),
    NUMERO INT,
    BAIRRO VARCHAR(30),
    CIDADE VARCHAR(30),
    ESTADO VARCHAR(30),
    UF VARCHAR(10)
);
```

## 📌 Como Executar o Projeto
1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```
2. **Abra o projeto no Visual Studio**
3. **Configure a string de conexão com o MySQL**
4. **Compile e execute a aplicação**
5. **Cadastre, visualize e gerencie pessoas no sistema!**

## 📜 Licença
Este projeto é distribuído sob a licença MIT. Sinta-se à vontade para usá-lo e melhorá-lo!

---
🔗 **Desenvolvido por [Hudney Gomes Nunes](https://www.linkedin.com/in/seu-perfil/)** 🚀

