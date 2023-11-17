# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

- Navegador de Internet
- Microsoft Visual Studio para execução do código

## Tipos de Testes

**Testes de Unidade**
-	Verificar individualmente cada componente da aplicação, como funções e métodos, para garantir que funcionem conforme o esperado.

**Testes de Integração**
- Avaliar como os diferentes módulos da aplicação se integram e se comunicam entre si.

**Testes de Aceitação**
- Garantir que a aplicação atenda aos critérios de aceitação definidos, incluindo requisitos funcionais e não funcionais.

**Testes de Desempenho**
- Avaliar o desempenho da aplicação, incluindo velocidade de carregamento, escalabilidade e capacidade de resposta sob carga.

**Testes de Segurança**
- Verificar se a aplicação é segura contra ameaças como ataques de injeção, autenticação inadequada e vulnerabilidades conhecidas.

**Teste de Responsividade**
- A aplicação deve manter o padrão de desempenho em qualquer sistema de acesso: Browser, Smartphone ou Tablet.

## Equipe de Teste
A equipe de teste conta com os membros, `Arthur Oliveira`, `Carlos Eduardo`, `Geovanne do Monte`,
`Lais Barbosa`, `Lucas Emanuel` e `Lucas Oliveira`, que serão responsáveis por conduzir os testes e relatar os resultados.


# Plano de Testes

Os testes funcionais a serem realizados na aplicação estão descritos a seguir:

## Teste Tela de Login
### Teste 01:
| Caso de Teste | T-01: Teste de Responsividade |
|---|---|
| Requisitos Associados |  `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela de login através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 02:
| Caso de Teste | T-02: Teste de Validação de Senha e Cadastro |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`: O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-09`: O sistema deve permitir que o usuário faça um cadastro com login e senha. |
| Objetivo do Teste |  Verificar a segurança de cadastro de senha confiabilidade de cadastros. Permitir que o usuário consiga fazer o cadastro e login. |
| Passos | `1.` Acessar tela de login e campo senha; `2.` Acessar link para cadastro preencher campos de cadastro. |
| Critérios de Êxito | `-` O campo senha bloqueia o dígito de mais caracteres que o permitido; <br> `-` A mensagem de limite de 8 caracteres aparece no campo senha. |
<br>


## Teste Tela Página Inicial
### Teste 01:
| Caso de Teste | T-01: Teste de Responsividade |
|---|---|
| Requisitos Associados |  `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 02:
| Caso de Teste | T-02: Teste de Navegabilidade |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a navegabilidade da aplicação e o devido redirecionamento dos links de navegação. |
| Passos | `1.` Acessar links da página inicial sendo direcionado para o site página Investimentos; |
| Critérios de Êxito | `-` Os links de navegação redireciona o usuário às páginas solicitadas. |
<br>


## Teste Tela de Receitas
### Teste 01:
| Caso de Teste | T-01: Teste de Responsividade |
|---|---|
| Requisitos Associados |  `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 03:
| Caso de Teste | **T-03: Teste de Cadastro de Receitas**  |
|---|---|
| Requisitos Associados | `RF-08`: O sistema deve permitir que o usuário registre suas receitas. (Títulos de receita fixa, títulos de receita variável, etc.). |
| Objetivo do Teste | Verificar preenchimento dos campos obrigatórios, e verificar se a aplicação insere novas informações à seção “Extratos”. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; <br> `2.` Verificar se os dados cadastrados aparecem na seção "Extratos". |
| Critérios de Êxito | `-` Preenchimento incompleto do formulário exibe mensagem de erro; <br> `-` Preenchimento completo do formulário exibe informações na tabela. |
<br>


## Tela de Despesas
### Teste 01:
| Caso de Teste | T-01: Teste de Responsividade |
|---|---|
| Requisitos Associados |  `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 02:
| Caso de Teste | **T-02: Teste de Cadastro de Despesas**  |
|---|---|
| Requisitos Associados | `RF-01`: Permitir que o usuário registre suas despesas fixas (aluguel, streaming, seguro, internet, etc.). |
| Objetivo do Teste | Verificar preenchimento dos campos obrigatórios, e verificar se a aplicação insere novas informações à seção “Extratos”. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; <br> `2.` Verificar se os dados cadastrados aparecem na seção "Transações". |
| Critérios de Êxito | `-` Preenchimento incompleto do formulário exibe mensagem de erro; <br> `-` Preenchimento completo do formulário exibe informações na tabela. |
<br>

## Tela de Transações
### Teste 01:
| Caso de Teste | T-01: Teste de Responsividade |
|---|---|
| Requisitos Associados |  `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 02:
| Caso de Teste | **T-02: Teste de Cadastro de Transações**  |
|---|---|
| Requisitos Associados | `RF-01`: Permitir que o usuário registre suas despesas fixas (aluguel, streaming, seguro, internet, etc.). |
| Objetivo do Teste | Verificar preenchimento dos campos obrigatórios, e verificar se a aplicação insere novas informações à seção “Extratos”. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; <br> `2.` Verificar se os dados cadastrados aparecem na seção "Transações". |
| Critérios de Êxito | `-` Preenchimento incompleto do formulário exibe mensagem de erro; <br> `-` Preenchimento completo do formulário exibe informações na tabela. |
<br>

## Tela de Usuários (apenas administradores da aplicação)
### Teste 01:
| Caso de Teste | T-01: Teste de Responsividade |
|---|---|
| Requisitos Associados |  `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 02:
| Caso de Teste | **T-02: Teste de Gestão de Usuários**  |
|---|---|
| Requisitos Associados | `RF-01`: Permitir que o usuário registre suas despesas fixas (aluguel, streaming, seguro, internet, etc.). |
| Objetivo do Teste | Verificar preenchimento dos campos obrigatórios, e verificar se a aplicação insere novas informações à seção “Extratos”. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; <br> `2.` Verificar se os dados cadastrados aparecem na seção "Extratos". |
| Critérios de Êxito | `-` Preenchimento incompleto do formulário exibe mensagem de erro; <br> `-` Preenchimento completo do formulário exibe informações na tabela. |
<br>

