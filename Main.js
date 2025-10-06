const samples = [
  'http://example.com/',
  'HTTP://EXAMPLE.COM:80/Path/',
  'http://user:pass@example.com:8080/a/b?c=1#frag',
  'http://[2001:db8::1]:8080/ipv6/path',
  'http://example.com/%2e%2e/%2e/',
  'http://my_host.com/path',
  'http://例え.テスト/パス',
  'file:///C:/Users/Test/Documents/file.txt',
  'http://example.com//double//slashes',
  'mailto:joe@example.com'
];

for (const s of samples) {
  try {
    const u = new URL(s);
    console.log('INPUT:', s);
    console.log('  href:', u.href);
    console.log('  origin:', u.origin);
    console.log('  scheme:', u.protocol);
    console.log('  hostname:', u.hostname);
    console.log('  port:', u.port || '(default)');
    console.log('  pathname:', u.pathname);
    console.log('  username:', u.username, 'password:', u.password);
    console.log('---');
  } catch (e) {
    console.log('INPUT:', s);
    console.log('  parse error (WHATWG URL):', e.message);
    console.log('---');
  }
}
