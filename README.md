# Unfolded Circle Launcher

[![Release](https://img.shields.io/github/actions/workflow/status/henrikwidlund/unfoldedcircle-launcher/github-release.yml?label=Release&logo=github)](https://github.com/henrikwidlund/unfoldedcircle-launcher/actions/workflows/github-release.yml)
[![CI](https://img.shields.io/github/actions/workflow/status/henrikwidlund/unfoldedcircle-launcher/ci.yml?label=CI&logo=github)](https://github.com/henrikwidlund/unfoldedcircle-launcher/actions/workflows/ci.yml)

This repository contains the code for a launcher application that can start other processes on the Unfolded Circle Remotes.
The main goal of this application is to include OpenSSL and ca-certificates automatically and add the necessary configuration
to let applications that have dependencies on those work without relying on the underlying operating system to make them available in the sandbox.

### Usage

1. Put the resources in the driver's bin folder
2. Name your own binary as `app` and put it in the same folder
3. Package the driver in a tar.gz file and install it on the remote using the Web Configurator

### Development

- [dotnet 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).
