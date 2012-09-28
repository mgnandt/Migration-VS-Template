using System;
using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace MigrationItemTemplateWizard
{
  public class MigrationWizard : IWizard
  {
    public void BeforeOpeningFile(ProjectItem projectItem)
    {
    }

    public void ProjectFinishedGenerating(Project project)
    {
    }

    public void ProjectItemFinishedGenerating(ProjectItem projectItem)
    {
    }

    public void RunFinished()
    {
    }

    public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
    {
      var timestamp = DateTime.Now.ToString("yyyyMMddhhmmss");
      replacementsDictionary["$migrationtimestamp$"] = timestamp;
      replacementsDictionary["$migrationclassname$"] = replacementsDictionary["$safeitemname$"];
      replacementsDictionary["$migrationfilename$"] = String.Format("{0}_{1}.cs", timestamp, replacementsDictionary["$safeitemname$"]);
    }

    public bool ShouldAddProjectItem(string filePath)
    {
      return true;
    }
  }
}
