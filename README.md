# livraria API

### Esta aplicação é uma API feita para o consumo do front end de uma livraria.<br>
### Foi construida utilziando o framework .NET 6.0, Entity Framework core utilziando um banco de dados em memória.<br>

Para utilizala, é necessário a instalação do Dotnet SDK 6.0 atravéz do [Link](https://dotnet.microsoft.com/en-us/download).<br>
Após a instalação do SKD, faça o download do repositório, e extraia aonde desejar.<br>
Em seguida, abra um console CMD, e navegue na pasta onde o projeto foi extraido.<br>
> Isso pode ser feito utilizando o comando `cd {Diretorio do projeto}\livraria\livraria\livraria.api`.<br>

Após entrar no diretorio corretamente, execute o comando `dotnet run` no CMD.<br>
A aplicação irá iniciar o processo de compilação e iniciar hosteada localmente na porta 7209.<br>
No navegador, digite a url `https://localhost:7209`. Caso a porta 7209 não funcione, a aplicação também eestá configurada para ser hosteada na porta de suporte 5209.<br>
Ao entrar na pagina, é apresentada a UI do Swagger, exibindo todas os endpoints.<br>
Para testar, basta clicar em um dos endpoints, um dropdown ira mostrar a documentação do endpoint selecionado, clicar em `Try it out`, e `Execute` para mandar a requisição. Logo a baixo é mostrado a resposta da API.<br>

> A aplicação utiliza um banco de dados em memória, portanto é necessário utilziar o comando POST inicialmente para que os outros comandos funcionem.


