# Comandos importantes de terminal utilizados no desenvolvimento

* Comando para criar o projeto razor mvc.

```shell
  dotnet new razor -o Razor-Crud -f net7.0 —auth Individual
```

* Comando para adicionar o entity framework no projeto.

```shell
  dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

* comando para gerar a migration.

```shell
  dotnet ef migrations add v1
```

* Aplica a migration no banco.

```shell
  dotnet ef database update
```

* Instala ferramenta de criação de crud automatizado ( scaffold ).

```shell
  dotnet tool install -g dotnet-aspnet-codegenerator
```

* Instala um pacote para conseguir gerar o scaffold a partir do entity framework.

```shell
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

* Gera o create de Student.

```shell
  dotnet aspnet-codegenerator razorpage Create Create -m Student -dc ApplicationDbContext -sqlite -udl  -outDir Pages/Students
```

* Gera o edit de Students.

```shell
  dotnet aspnet-codegenerator razorpage Edit Edit -m Student -dc ApplicationDbContext -sqlite -udl  -outDir Pages/Students
```

* Gera o Delete de Student.

```shell
  dotnet aspnet-codegenerator razorpage Delete Delete -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students
```

* Gera o details de Student.

```shell
  dotnet aspnet-codegenerator razorpage Details Details -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students
```

* Gera o index de Student.

```shell
  dotnet aspnet-codegenerator razorpage Index List -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students
```

* Gera o index de Premium (Mesmos comandos para tabela de premium).

```shell
  dotnet aspnet-codegenerator razorpage Create Create -m Premium -dc ApplicationDbContext -sqlite -udl -outDir Pages/Premiuns
```
















