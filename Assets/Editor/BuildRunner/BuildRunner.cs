using SyntaxTree.VisualStudio.Unity.Bridge;

namespace LCGC.BuildRunner
{
    public static class BuildRunner
    {
        public static void BuildProject()
        {
            // generate the project and copy the UnityAssemblies for NUnit 
            ProjectFilesGenerator.GenerateProject();
        }
    }
}
