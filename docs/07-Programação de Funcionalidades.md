# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

###  **Landing Page**

Tela de recepção do usuário.

![Landing Page](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/ec1519fc-7945-46cd-9ae8-410d577d25dc)
<sub>*Figura: Landing Page*</sub>

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-17| Permitir que o usuário conheça a plataforma | Index.cshtml / Privacy.cshtml | 

**Codigo Fonte**
![landingpage](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/127629619/9b14e721-6c7c-4cfd-b436-356a789793b4)

###  **Tela de cadastro de novo usuário**

Tela que permite ao usuário fazer seu cadastro para ter acesso às funções da aplicação.

![Cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/dfc33262-32a4-490e-8260-f52522b80ac6)
<sub>*Figura: Tela de cadastro*</sub>

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-09| Permitir que o usuário faça um cadastro com login e senha. | Create.cshtml / Delete.cshtml/ Index.cshtml/ Views.usuarios | 

**Código fonte**
![cadastrar](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/127629619/948ad8d3-3624-4a3e-be3e-965b81775d6f)

###  **Tela de login**

Tela que permite ao usuário acessar ao seu perfil com autenticação via login e senha.

![Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/48902f8b-bb12-4a1b-a2bf-06cc9c63984e)
<sub>*Figura: Tela de login*</sub>

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-09| Permitir que o usuário faça um cadastro com login e senha. | login.cshtml / Views.usuarios | 

**Código fonte**

![login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/127629619/bf835055-96c1-4a83-8af8-ce3433b97e09)


###  **Tela de Receitas**

Tela que permite ao usuário fazer ao usuário fazer o acompanhamento e gestão de todas as receitas cadastradas.

![Receitas](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/339867b1-acf0-4b0e-b816-5d8dba50b3d4)
<sub>*Figura: Tela de receitas*</sub>

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-06| RF-06: Permitir que o usuário registre suas receitas esporádicas | 
RF-07: Permitir que o usuário registre suas receitas com “prazo de validade”|  | 

###  **Tela de Despesas**

Tela que permite ao usuário fazer ao usuário fazer o acompanhamento e gestão de todas as despesas cadastradas.

![Despesas](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/e6197ec2-00e2-438d-a54e-269a79b7fdcf)
<sub>*Figura: Tela de despesas*</sub>

**Código fonte**


###  **Tela de Transações**

Tela que permite ao usuário fazer ao usuário fazer o acompanhamento e gestão de todas as transações cadastradas, seja ela de despesas ou receitas.

![Transacoes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/b12e075d-a763-4a8f-9726-69f1c35698e9)
<sub>*Figura: Tela de transações*</sub>

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-08| RF-08: Permitir que o usuário registre seus investimentos | Views.transacoes/ Create.cshtml/ Delete.cshtml/ Edit.cshtml |

**Codigo Fonte**

![transação](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/127629619/f5e0bc39-cfbe-405b-82dd-97685c274ff3)

###  **Tela de Usuários**

Tela que permite aos gestores da aplicação fazer a consulta, gestão e acompanhamento dos cadastrados na aplicação.

![Tela de Usuários (adm)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/122227953/886638fa-c350-40ff-8de8-d52781ac5d16)
<sub>*Figura: Tela de usuários*</sub>


|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-0|


**Codigo Fonte**

![usuario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil/assets/127629619/8446df03-b011-4f57-8fad-8777385c3d82)




# Instruções de acesso
Abra um navegador de internet e insira a seguinte URL: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-t11-projcontrolafacil

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
