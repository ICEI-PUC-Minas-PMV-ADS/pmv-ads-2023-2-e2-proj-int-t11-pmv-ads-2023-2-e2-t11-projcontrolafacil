# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

- Site publicado na Internet
- Navegador de Internet
- Conectividade de Internet para acesso à aplicação

Os testes funcionais a serem realizados na aplicação estão descritos a seguir:

## Tela de Investimentos

### Teste 01:
| Caso de Teste | **T-01: Teste de Responsividade**  |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a acessibilidade da aplicação e seu comportamento em dispositivos de diferentes tipos e tamanhos. |
| Passos | `1.` Acessar a tela de investimentos através de dispositivos com diferentes dimensões de tela; |
| Critérios de Êxito | `-` A aplicação se adequa ao tamanho de exibição requisitado; <br> `-` A aplicação não oculta informações importantes quando acessada a partir de dispositivos com telas menores. |
<br>

### Teste 02:
| Caso de Teste | **T-02: Teste de Dark Mode**   |
|---|---|
| Requisitos Associados | `RF-13`: O sistema deve permitir que o usuário opte pelo "Dark Mode"; <br> `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Testar o funcionamento do modo escuro (Dark Mode) da aplicação. |
| Passos | `1.` Acessar a tela de investimentos através de dispositivos com diferentes dimensões de tela; <br> `2.` Ativar e desativar a função Dark Mode através do ícone de Lua — ou Sol, caso já esteja ativada —, presente no header da página; |
| Critérios de Êxito | `-` A aplicação altera o modo de exibição de Light Mode para Dark Mode e vice-versa. |
<br>

### Teste 03:
| Caso de Teste | **T-03: Teste de Cadastro de Investimentos**  |
|---|---|
| Requisitos Associados | `RF-08`: O sistema deve permitir que o usuário registre seus investimentos. (Títulos de renda fixa, títulos de renda variável, etc.). |
| Objetivo do Teste | Verificar preenchimento dos campos obrigatórios, e verificar se a aplicação insere novas informações à seção “Carteira”. |
| Passos | `1.` Acessar a tela de investimentos através de dispositivos com diferentes dimensões de tela; <br> `2.` Preencher os dados na seção “Cadastrar novo aporte”; <br> `3.` Verificar se os dados cadastrados aparecem na seção "Carteira". |
| Critérios de Êxito | `-` Preenchimento incompleto do formulário exibe mensagem de erro; <br> `-` Preenchimento completo do formulário exibe informações na seção “Carteira”. |
<br>

### Teste 04:
| Caso de Teste | T-04: Teste de Navegação e Menu Oculto |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a navegabilidade da aplicação e o devido redirecionamento dos links de navegação. Além disso, realizar o teste de navegação dos links incluídos no “Menu Hambúrguer” disponível nas telas de dispositivos mobile. |
| Passos | `1.` Acessar a tela de investimentos através de dispositivos com diferentes dimensões de tela; `2.` Acessar links disponíveis no menu de navegação presente no header da página; |
| Critérios de Êxito | `-` O menu de navegação redireciona o usuário às páginas solicitadas; <br> `-` A aplicação exibe o menu de navegação oculto em dispositivos móveis; <br> `-` Os links de navegação do menu oculto redirecionam o usuário conforme solicitação. |
<br>

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
| Caso de Teste | T-02: Teste de Navegabilidade |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`:  O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-04`: O sistema deve ser responsivo em qualquer sistema de acesso: Browser, Smartphone ou Tablet. |
| Objetivo do Teste | Verificar a navegabilidade da aplicação e o devido redirecionamento dos links de navegação. |
| Passos | `1.` Acessar links da página de login sendo direcionado para o site página Investimentos; |
| Critérios de Êxito | `-` Os links de navegação redireciona o usuário às páginas solicitadas. |
<br>

### Teste 03:
| Caso de Teste | T-03: Teste de Validação de Senha e Cadastro |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`: O sistema deve ser acessível e de fácil usabilidade pelo usuário; <br> `RNF-09`: O sistema deve permitir que o usuário faça um cadastro com login e senha. |
| Objetivo do Teste |  Verificar a segurança de cadastro de senha confiabilidade de cadastros. Permitir que o usuário consiga fazer o cadastro e login. |
| Passos | `1.` Acessar tela de login e campo senha; `2.` Acessar link para cadastro preencher campos de cadastro. |
| Critérios de Êxito | `-` O campo senha bloqueia o dígito de mais caracteres que o permitido; <br> `-` A mensagem de limite de 8 caracteres aparece no campo senha. |
<br>

### Teste 04:
| Caso de Teste | T-04: Teste de Ponta a Ponta |
|---|---|
| Requisitos Associados | `RNF-01`: A aplicação deve manter o padrão de desempenho — definido pela equipe — em qualquer sistema de acesso: Browser, Smartphone ou Tablet; <br> `RNF-03`: O sistema deve ser acessível e de fácil usabilidade pelo usuário. |
| Objetivo do Teste | Verificar o funcionamento completo de Recuperação de senha e o redirecionamento de página  com preenchimento de campos.
| Passos | `1.` Acessar a opção Esqueceu a senha; `2.` Direcionado a tela de recuperação de senha; `3.` Receber notificação de email. |
| Critérios de Êxito | `-` O usuário é direcionado para pagina de recuperação de senha; <br> `-` O usuário é notificado via email. |
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

### Teste 03:
| Caso de Teste | **T-03: Teste de Cadastro de Receitas**  |
|---|---|
| Requisitos Associados | `RF-08`: O sistema deve permitir que o usuário registre suas receitas. (Títulos de receita fixa, títulos de receita variável, etc.). |
| Objetivo do Teste | Verificar preenchimento dos campos obrigatórios, e verificar se a aplicação insere novas informações à seção “Extratos”. |
| Passos | `1.` Acessar a tela inicial através de dispositivos com diferentes dimensões de tela; <br> `2.` Verificar se os dados cadastrados aparecem na seção "Extratos". |
| Critérios de Êxito | `-` Preenchimento incompleto do formulário exibe mensagem de erro; <br> `-` Preenchimento completo do formulário exibe informações na seção “Extratos”. |
<br>

