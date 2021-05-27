# Ecommerce-TDD
Projeto Ecommerce DotNet 6.0 com TDD

# Orientação

Para rodar utilizando Migrations e o banco SQL Server abrir o VS2019,
marcar "ApiEcommerce" como "Set as StartUp Project" e dois ir até 
Tools -> Nugget Package Manage -> Package Manager Console -> Selectionar
como Default project: ModelData, e aplicar o comando abaixo:

#

Basicamente é isso, e para demonstração de uso da API, utilizar o Swagger,
pois esse projeto contempla apenas o back-end.

Vale ressaltar que ao rodar a aplicação não terá dados,
logo utilizando o Swagger executar o método POST /api/Spotify/RealizarCargaInicial
essa operação fará a carga inicial dos dados utilizando a API do Spotify
