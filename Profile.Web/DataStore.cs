namespace Profile.Web;

public class DataStore
{
    public Language[] Languages = [
    new ("C#", "My favourite"),
new ("JS", "The worst"),
new ("C++", "Why does it exists?"),
new ("C", "Hate it"),
new ("GO", "Just touch"),
new ("Python", ""),
new ("F#", ""),
new ("Rust", ""),
new ("PowerShell", "The best shell"),
new ("bash", "bash"),
new ("SQL", "Base queries"),
];

    public Project[] Projects = [
        new("DomraSinForms", "Simple web app for creating surveys, forms etc.", "https://github.com/Katy248/DomraSinForms"),
new("Staerf's Patriots site", "Site for 'C..' biography written by Staerf's Patriots. Currently not hosted so link ",
"https://web.archive.org/web/20231109164418/https://%D0%BF%D0%B0%D1%82%D1%80%D0%B8%D0%BE%D1%82%D1%8B-%D1%81%D1%82%D0%B0%D0%B5.%D1%80%D1%84/"),
new("BrainFuck Compiler", "Not a real compiler but an enterpreter written in `C#`",
"https://github.com/Katy248/BrainFuckCompiler"),
];

}
public record Language(string Name, string SmallDescription);
public record Project(string Name, string SmallDescription, string Link);
