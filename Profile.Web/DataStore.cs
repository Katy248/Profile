namespace Profile.Web;

public class DataStore
{
    public Language[] Languages =
    [
        new ("C#", "My favourite", Rating: 100),
        new ("Pascal", "Firs language"),
        new ("JS", "The worst"),
        new ("GO", "Basic"),
        new ("Python", ""),
        new ("F#", ""),
        new ("PowerShell", "The best shell"),
        new ("bash", "bash"),
        new ("SQL", "Base queries"),
        new ("C++", "Why does it exists?", Rating: -1),
        new ("C", "Hate it", Rating: -2),
        new ("Rust", "", -3),
    ];

    public Project[] Projects =
    [
        new("DomraSinForms", "<p>Simple web app for creating surveys, forms etc.</p>Wrote it as diploma project in college.", "https://github.com/Katy248/DomraSinForms"),
        new("Staerf's Patriots site", "Site for 'C..' biography written by Staerf's Patriots. <p>Build as joke.</p>Currently not hosted so link:",
        "https://web.archive.org/web/20231109164418/https://%D0%BF%D0%B0%D1%82%D1%80%D0%B8%D0%BE%D1%82%D1%8B-%D1%81%D1%82%D0%B0%D0%B5.%D1%80%D1%84/"),
        new("Personal site for yugh78", "Helped my friend to build and start hosting personal site", "http://yugh78.github.io"),
        new("BrainFuck Compiler", "Not a real compiler but an enterpreter for <a href='https://ru.wikipedia.org/wiki/Brainfuck' target='_blank'><code>brainfuck</code></a> written in <code>C#</code>",
        "https://github.com/Katy248/BrainFuckCompiler"),
        new("kvtheme", "Theme for <a href='https://ohmyposh.dev/'>oh-my-posh</a>", "https://github.com/Katy248/kvtheme")
    ];

    public Tool[] Tools =
    [
        new ("Neovim", Application: "Currently my main IDE"),
        new("VS Code", null, "One of the main text and code editors"),
        new("make", null, "Building my projects and other large scripts"),
        //new("Visual Studio", "The best IDE for <code>C#</code> for now", Deprecated: true),
        // new("Raider", "Not so powerful as VS", Deprecated: true),
        // new("helix", null, "The best code editor for terminal"),
    ];
    public Link[] Links =
    [
        new ("GitLab", "https://gitlab.com/Katy248"),
        new ("GitHub", "https://github.com/Katy248"),
    ];
    public string[] CoolQuotes =
    [
        "Make it home or die trying",
    ];
    public string RandomCoolQuote()
    {
        var index = Random.Shared.Next(CoolQuotes.Length - 1);
        return CoolQuotes[index];
    }
}
public record Language(string Name, string SmallDescription, int Rating = 0);
public record Project(string Name, string SmallDescription, string Link);
public record Tool(string Name, string? Opinion = null, string? Application = null, bool Deprecated = false);
public record Link(string Name, string Url);
