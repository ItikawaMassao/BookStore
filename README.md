# Book Store
Projeto CRUD de livros, utilizando DDD (_Domain Driven Design_)

## Pré-Requisitos
- .NET Framework 4.6.2 +
- VisualStudio 2013 (12) +

## Características
- [x] DDD;
- [x] MVC;
- [x] Web API;
- [x] EntityFramework;
- [x] Migrations;
- [x] Simple Injector;
- [x] AutoMapper;
- [x] Bootstrap;
- [x] JQuery;
- [x] Swagger;


## Configurações
- [Book.Store/Book.Store.WebApi/Book.Store.WebApi.csproj](https://github.com/ItikawaMassao/BookStore/blob/5d0ba7f3d1780e9b90f68dbe409320dfd748dfb6/Book.Store/Book.Store.WebApi/Book.Store.WebApi.csproj "Book.Store/Book.Store.WebApi/Book.Store.WebApi.csproj")
  - Definir a porta a utilizar.
- [Book.Store/Book.Store.MVC/Web.config](https://github.com/ItikawaMassao/BookStore/blob/57fc351feb1b6604a5ded95b15aad78dcd14e49c/Book.Store/Book.Store.MVC/Web.config "Book.Store/Book.Store.MVC/Web.config")
	- Utilizar a porta definida anteriormente na chave **endpointApiService**.
- _Startar_ os dois projetos simultaneamente (**MVC** e **WebApi**)