# FluentMigrator Visual Studio Template Extension

## How to upgrade for a new version of Visual Studio

1.  Open the `source.extension.vsixmanifest` file

2.  Update the installation targets to include the new Visual Studio version.
    The version range is usually exclusive on the upper end.

3.  Update the prerequisite versions to include the new Visual Studio version.
    The version range is usually exclusive on the upper end.

## Code Signing Certificate

If the code signing certificate has changed, the PublicKeyToken of the
MigrationItemTemplateWizard assembly will change. Since the full name of this
assembly is referenced by the MigrationItemTemplate project, you need to update
the PublicKeyToken in the `MigrationItemTemplate.vstemplate` file.
