cd C:\Users\agustin.rojas\Desktop\Proyectos\Vueling3Layers\Student.Presentation.WinSite
nuget pack .\Student.Presentation.WinSite.csproj -IncludeReferencedProjects
move Student.Presentation.WinSite.1.0.0.nupkg C:\StudentPackages

cd C:\Users\agustin.rojas\Desktop\Proyectos\Vueling3Layers\Student.Business.Logic
nuget pack .\Student.Business.Logic.csproj -IncludeReferencedProjects
move Student.Business.Logic.1.0.0.nupkg C:\StudentPackages

cd C:\Users\agustin.rojas\Desktop\Proyectos\Vueling3Layers\Student.Common.Logic
nuget pack .\Student.Common.Logic.csproj -IncludeReferencedProjects
move Student.Common.Logic.1.0.0.nupkg C:\StudentPackages

cd C:\Users\agustin.rojas\Desktop\Proyectos\Vueling3Layers\Student.DataAccess.Dao
nuget pack .\Student.DataAccess.Dao.csproj -IncludeReferencedProjects
move Student.DataAccess.Dao.1.0.0.nupkg C:\StudentPackages

PAUSE



