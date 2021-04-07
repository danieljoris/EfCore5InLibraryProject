<!-- PROJECT LOGO -->
<br />
<p align="center">
  <svg
   alt="Book icon"
   xmlns="http://www.w3.org/2000/svg" width="150" height="150" fill="#682179" class="bi bi-book-half" viewBox="0 0 16 16">
  <path d="M8.5 2.687c.654-.689 1.782-.886 3.112-.752 1.234.124 2.503.523 3.388.893v9.923c-.918-.35-2.107-.692-3.287-.81-1.094-.111-2.278-.039-3.213.492V2.687zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"/>
</svg>

  <h3 align="center">EfCore5InLibraryProject</h3>

  <p align="center">
    Este projeto tem como intenção mostrar que é possível você fazer uso da CLI do Entity Framework Core 5 sem a necessidade de um projeto ASP .NET Core API/MVC.
    <br />
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Reportar Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">English version</a>
    ·
  </p>
</p>

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Índice</summary>
  <ol>
    <li>
      <a href="#about-the-project">Sobre o projeto</a>
      <ul>
        <li><a href="#built-with">Construído com</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Primeiros passos</a>
      <ul>
        <li><a href="#prerequisites">Pré-requisitos</a></li>
        <li><a href="#usage">Uso</a></li>
      </ul>
    </li>
    <li><a href="#contributing">Contribuindo</a></li>
    <li><a href="#license">Licença</a></li>
  </ol>
</details>

<br>
<br>

## 🏗 Sobre o projeto

O projeto tem a intenção de mostrar que é possível fazer uso do Entity Framework Core 5 sem a necessidade de um projeto ASP .NET Core 5 WebAPI/MVC/ConsoleApp.

### Construído com
- [.NET 5.0.5](https://github.com/dotnet/core)
- [Microsoft Entity Framework Core 5.0.5](https://github.com/dotnet/efcore)
- [Npgsql Entity Framework Core Provider 5.0.2](https://github.com/npgsql/efcore.pg)

<br>

## 🎈 Primeiros passos

###  Pré-requisitos
Para que você consiga executar o projeto será necessário instalar as seguintes ferramentas em seu sistema operacional:

- .NET 5.0.5 SDK - [Download](https://dotnet.microsoft.com/download/dotnet/5.0)
- Docker - [Download](https://docs.docker.com/get-docker/)

### Uso

1. Faça um clone do repositório
```sh
git clone https://github.com/danieljoris/EfCore5InLibraryProject.git
```

2. Restaure as dependência e ferramentas do projeto
```sh
dotnet restore
```

3. Crie o container do banco de dados Postgres
```sh
docker-compose --env-file .\.env.dev up -d
```

4. Pronto! Agora você já pode fazer uso das `Migrations` e demais funcionalidades fornecidas pela CLI do EF Core 5 sem a necessidade de um projeto ASP .NET Core 5 WebAPI/MVC.

Não se esqueça que para executar os comandos relacionados ao EF Core você deve estar no diretório `src\EfCore5InLibraryProject.Data`😉

Para mais informações a respeito do uso da CLI do EF Core 5 visite: https://docs.microsoft.com/pt-br/ef/core/cli/dotnet

<br>

## 🚀 Contribuindo
As contribuições são o que tornam a comunidade de código aberto um lugar incrível para aprender, inspirar e criar. Quaisquer contribuições que você fizer serão muito bem-vindas🐱‍💻

1. Faça um `Fork` do projeto
2. Crie seu `branch` de recurso (git checkout -b feature / AmazingFeature)
3. Faça commit de suas alterações (git commit -m 'Add some AmazingFeature')
4. Envie para o Branch (recurso de origem do git push / AmazingFeature)
5. Abra uma solicitação pull

<br>

## 📑 Licença
Distribuído sob a licença MIT. Consulte a [`LICENÇA`](https://github.com/othneildrew/Best-README-Template) para obter mais informações. 
