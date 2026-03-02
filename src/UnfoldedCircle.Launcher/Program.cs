using System.Diagnostics;

var appDir = AppContext.BaseDirectory;

// Set up certificate paths for OpenSSL
var certFile = Path.Combine(appDir, "certs", "ca-certificates.crt");
var certDir = Path.Combine(appDir, "certs");

if (File.Exists(certFile))
    Environment.SetEnvironmentVariable("SSL_CERT_FILE", certFile);
else if (Directory.Exists(certDir))
    Environment.SetEnvironmentVariable("SSL_CERT_DIR", certDir);

// Launch the real application
var appPath = Path.Combine(appDir, "app");
if (!File.Exists(appPath))
{
    Console.Error.WriteLine($"[Launcher] ERROR: Application binary not found at {appPath}");
    return 1;
}

var startInfo = new ProcessStartInfo
{
    FileName = appPath,
    UseShellExecute = false
};

// Pass through all command line arguments
foreach (var arg in args)
    startInfo.ArgumentList.Add(arg);

Console.WriteLine($"[Launcher] Starting {appPath}...");

using var process = Process.Start(startInfo);
if (process == null)
{
    Console.Error.WriteLine("Failed to start application");
    return 1;
}

await process.WaitForExitAsync();
return process.ExitCode;