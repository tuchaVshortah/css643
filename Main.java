import java.net.URI;

public class ParseURI {
    public static void main(String[] args) {
        String[] samples = {
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
        for (String s : samples) {
            try {
                URI u = new URI(s);
                System.out.println("INPUT: " + s);
                System.out.println("  scheme: " + u.getScheme());
                System.out.println("  authority: " + u.getAuthority());
                System.out.println("  host: " + u.getHost());
                System.out.println("  port: " + u.getPort());
                System.out.println("  path: " + u.getPath());
                System.out.println("  rawPath: " + u.getRawPath());
                System.out.println("  userInfo: " + u.getUserInfo());
                System.out.println("---");
            } catch (Exception e) {
                System.out.println("INPUT: " + s + " -> parse error: " + e);
                System.out.println("---");
            }
        }
    }
}
