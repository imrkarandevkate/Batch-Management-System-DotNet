using System;
using System.Reflection;

namespace Student_Batch_Mangement_System_ServerSide.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}