using System;
using System.Reflection;

namespace HTTP5101_Assgn2_AlbyBaby.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}