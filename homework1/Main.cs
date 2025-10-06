using System;

class ParseUri {
    static void Main() {
        string[] samples = {
            "http://example.com/",
            "HTTP://EXAMPLE.COM:80/Path/",
            "http://user:pass@example.com:8080/a/b?c=1#frag",
            "http://[2001:db8::1]:8080/ipv6/path",
            "http://example.com/%2e%2e/%2e/",
            "http://my_host.com/path",
            "http://例え.テスト/パス",
            "file:///C:/Users/Test/Documents/file.txt",
            "http://example.com//double//slashes",
            "mailto:joe@example.com"
        };

        foreach (var s in samples) {
            try {
                var u = new Uri(s);
                Console.WriteLine("INPUT: " + s);
                Console.WriteLine("  Scheme: " + u.Scheme);
                Console.WriteLine("  Host: " + (u.IsAbsoluteUri ? u.Host : "(none)"));
                Console.WriteLine("  Port: " + (u.IsDefaultPort ? "(default)" : u.Port.ToString()));
                Console.WriteLine("  AbsolutePath: " + u.AbsolutePath);
                Console.WriteLine("  UserInfo: " + u.UserInfo);
                Console.WriteLine("---");
            } catch (Exception e) {
                Console.WriteLine("INPUT: " + s + " -> parse error: " + e.Message);
                Console.WriteLine("---");
            }
        }
    }
}
