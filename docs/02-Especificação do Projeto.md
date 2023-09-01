# Especificações do Projeto

A equipe realizou pesquisas e entrevistas com potenciais usuários da aplicação visando traçar quais problemas o software resolverá. A partir disso, os levantamentos foram compilados na forma de Personas e Histórias de Usuários, conforme apresentado a seguir.


## Histórias de Usuário

### BEATRIZ CORDEIRO

| **Idade**              | 49 anos                    |
|------------------------|----------------------------|
| **Principais aplicativos** | Banking; Streaming; Whatsapp; Instagram; TikTok; YouTube; Twitter |
| **Ocupação**           | Analista Financeiro        |
| **Motivações**         | Família; Busca por conhecimento |
| **Objetivos**          | Seguir evoluindo profissionalmente |
| **Hobbies**            | Leitura; Filmes e Séries; Língua Estrangeira; Viagens |

### LEONARDO MACEDO

| **Idade**              | 21 anos                    |
|------------------------|----------------------------|
| **Principais aplicativos** | Streaming; Whatsapp; Instagram; Telegram; YouTube; Twitter; Discord |
| **Ocupação**           | Assistente de Suporte; Estudante de SI |
| **Motivações**         | Amigos; Tecnologia         |
| **Objetivos**          | Trabalhar como gestor em tecnologia (gestão de pessoal) |
| **Hobbies**            | Games online; Filmes e Séries |

### LUCIANO MOTTA

| **Idade**              | 30 anos                    |
|------------------------|----------------------------|
| **Principais aplicativos** | Streaming; Whatsapp; Instagram; YouTube |
| **Ocupação**           | Bombeiro Militar; Estudante de E. Física |
| **Motivações**         | Atividades Físicas; Família |
| **Objetivos**          | Ter controle sobre o próprio tempo |
| **Hobbies**            | Crossfit; Filmes e Séries; Viagens |

## Histórias de Usuário

| **Eu como...**        | **Quero/desejo...**       | **Para...**                 |
|-----------------------|---------------------------|-----------------------------|
| Beatriz Cordeiro      | Cadastrar minhas despesas mensais | Saber quanto devo poupar dos meus rendimentos mensais para que as despesas sejam satisfeitas. |
| Leonardo Macedo       | Cadastrar uma compra futura | Planejar e saber quanto devo poupar mensalmente. |
| Luciano Motta         | Cadastrar meus investimentos | Entender e acompanhar onde e quanto do meu patrimônio está investido. |
| Eduardo Lima          | Cadastrar minhas despesas dinâmicas mensais | Entender e classificar qual a média das minhas despesas com combustível, por exemplo. |
| Felipe Lima           | Cadastrar minhas despesas imprevistas | Prever e planejar possíveis gastos excedentes mensais. |
| Julia Bezerra         | Receber dicas e lembretes de gerenciamento financeiro | Manter uma vida financeira controlada e saudável. |
| Rodrigo Alves         | Administrar o dinheiro para garantir aposentadoria | Ter a segurança de aposentadoria privada. |


## Requisitos

As tabelas a seguir, apresentam os requisitos funcionais e não funcionais da aplicação, além da definição de seu nível de prioridade classificados em: alta, média ou baixa prioridade:


## Requisitos Funcionais (RF)

| **ID** | **Descrição** | **Prioridade** |
|--------|---------------|----------------|
| RF-01  | O sistema deve permitir que o usuário registre suas despesas fixas (aluguel, streaming, seguro, internet, etc.). | Alta |
| RF-02  | O sistema deve permitir que o usuário registre suas despesas esporádicas (corte de cabelo, jantar em restaurante, passeio no parque de diversões, etc.). | Alta |
| RF-03  | O sistema deve permitir que o usuário registre suas despesas com “prazo de validade” (compras parceladas, financiamentos, etc). | Alta |
| RF-04  | O sistema deve permitir que o usuário registre uma meta de gastos (seja ela semanal, mensal ou anual). | Baixa |
| RF-05  | O sistema deve permitir que o usuário registre suas receitas fixas. (salário, mesada, etc.). | Alta |
| RF-06  | O sistema deve permitir que o usuário registre suas receitas esporádicas (dividendos, rendimentos, participação nos lucros, etc.). | Alta |
| RF-07  | O sistema deve permitir que o usuário registre suas receitas com “prazo de validade” (vendas parceladas, etc.). | Alta |
| RF-08  | O sistema deve permitir que o usuário registre seus investimentos. (Títulos de renda fixa, títulos de renda variável, etc.). | Baixa |
| RF-09  | O sistema deve permitir que o usuário faça um cadastro com login e senha. | Alta |
| RF-10  | O sistema deve permitir que o usuário registre despesas imprevistas (veterinário, hospital, medicamentos, etc.). | Média |
| RF-11  | O sistema deve permitir que o usuário especifique em seu cadastro qual o motivo pelo qual ele está utilizando a aplicação (gerenciamento financeiro, dívidas, controle de investimentos, etc.). | Baixa |
| RF-12  | O sistema deve exibir notificações (pop-ups) com dicas para uma vida financeira mais saudável. | Baixa |
| RF-13  | O sistema deve permitir que o usuário opte pelo “DarkMode”. | Baixa |
| RF-14  | O sistema deve permitir que a página de registros seja customizável conforme as necessidades do usuário. | Baixa |
| RF-15  | O sistema deve permitir que o usuário faça a importação do seu extrato na extensão .csv. | Baixa |
| RF-16  | * Histórico de transações, foco em manter um histórico completo das transações financeiras realizadas pelos usuários. | Média |
| RF-17  | * Gerenciar o perfil como permitir que os usuários atualizem suas informações de perfil, endereço, número de telefone e foto. | Média |
| RF-18  | * Oferecer gráficos e relatórios para visualização clara dos fluxos financeiros. | Alta |
| RF-19  | * Orçamentos, permitir que os usuários definam metas de gastos e criem orçamentos mensais ou anuais. | Baixa |
| RF-20  | * Alertar os usuários quando estiverem se aproximando dos limites de orçamento. | Baixa |

## Requisitos Não Funcionais (RNF)

| **ID** | **Descrição** | **Prioridade** |
|--------|---------------|----------------|
| RNF-01  | O sistema deve ser acessível e de fácil usabilidade pelo usuário. | Alta |
| RNF-02  | A aplicação deve ser responsiva e adequada a qualquer sistema de acesso (Desktop, Smartphone ou Tablet). | Alta |
| RNF-03  | O sistema deve permitir fácil manutenibilidade. | Média |
| RNF-04  | * Tempo de resposta de 5 segundos. | Alta |


## Restrições

Os fatores apresentados na tabela a seguir tratam dos processos que restringem o desenvolvimento da plataforma:

| **ID** | **Descrição** |
|--------|---------------|
| RE-01  | A Etapa 1 da aplicação tem como prazo de entrega a data: 03/09/2023 |
| RE-02  | Alguns membros da equipe podem ser mais ativos e engajados do que outros, levando a desequilíbrios na carga de trabalho e na contribuição geral. Então todos devem ter o mínimo de participação e disposição de tempo. |
| RE-03  | A equipe não pode contratar nem delegar funções à terceiros |
| RE-04  | Acesso limitado a ferramentas ou tecnologias e falta de suporte podem dificultar a realização das tarefas de maneira eficaz. |
| RE-05  | A diferença de fusos horários e a dispersão geográfica podem dificultar a comunicação em tempo real e a coordenação eficaz, mantenha-se informado horários e paciente com os colaboradores da equipe. |


## Diagrama de Casos de Uso

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/131923836/2113567e-c7fb-465f-9165-f62ba4a1f9d2)


- Associação

  Usuário faz o login. Cadastra suas receitas. Registra despesas. Registra Investimentos. 
Consulta saldo.

- Inclusão

  Toda vez que o usuário fizer Login, o aplicativo verificará a senha automaticamente.

- Extensão

  Ocorrerá apenas quando o usuário digitar senha errada, aparecerá a mensagem de erro de login.

- Generalização/Herança

  Ao registrar as Despesas  o usuário poderá optar por registrar como Fixas ou Esporádicas.
O mesmo ocorre em Cadastrar Receitas.



