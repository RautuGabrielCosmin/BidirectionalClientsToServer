# C# Windows Forms TCP Server–Client Application

A .NET-based TCP server and Windows Forms client showcasing multi-client communication, command broadcasting, and UI-driven connection management.

## Description

This repository contains two WinForms applications—a **Server** and a **Client**—that communicate over TCP:

- **Server**:  
  - Listens on a user‑specified port (default 5000) for incoming connections.  
  - Accepts multiple clients using one background thread per connection.  
  - Displays connection status and messages in a central status textbox.  
  - Allows typing a command in the UI and broadcasting it to all connected clients.  
  - Gracefully stops and disconnects all clients on demand.

- **Client**:  
  - Connects to the server at a specified IP address (default 127.0.0.1) and port.  
  - Sends an initial greeting message and processes server replies in real time.  
  - Displays incoming server messages in its own UI.  
  - Lets the user send commands back to the server.  
  - Supports clean disconnect and re‑connect without restarting the application.

Both projects share an `InvokeEx` extension method to marshal background‑thread updates safely onto the UI thread.

## Key Features

- **Multi‑Client Support**  
  Dedicated background thread per client on the server side for true concurrent handling.

- **Command Broadcasting**  
  Type in a command on the server UI and push it out to every connected client at once.

- **Thread‑Safe UI Updates**  
  `InvokeEx` extension ensures cross‑thread calls update the WinForms controls correctly.

- **Graceful Shutdown**  
  Server can stop listening, close all client connections, and reset its UI without forcing the process to exit.

## Prerequisites

- **.NET Framework 4.7.2** (or higher)  
- **Visual Studio 2017** (or higher) / Visual Studio Community Edition  
- Windows OS (WinForms applications)

## Setup & Usage

1. **Clone the repository**  
   ```bash
   git clone https://github.com/your-username/csharp-winform-tcp.git
   cd csharp-winform-tcp
   ```

2. **Open the solution**  
   - Double‑click `WindowsFormsApp.sln` in Visual Studio.

3. **Build the solution**  
   - Choose **Build → Build Solution** (or press **Ctrl+Shift+B**).

4. **Run the Server**  
   - Set the **WindowsFormsApp** project as Startup.  
   - Press **F5**.  
   - Enter a port (or leave 5000), then click **Start Server**.

5. **Run one or more Clients**  
   - In Visual Studio, right‑click **WindowsFormsAppClient** and choose **Set as Startup Project**, then **Start**.  
   - Enter the server IP (e.g. `127.0.0.1`) and port (`5000`), then click **Connect**.  
   - Type commands in the client UI to send to the server; server replies appear in both UIs.

6. **Shut down**  
   - Use **Stop Server** on the server form to disconnect all clients.  
   - Use **Disconnect** on the client form to safely close the connection.

## Project Structure

```
├── WindowsFormsApp/               # Server project
│   ├── Form1.cs                   # Main server form and logic
│   ├── ISynchronizeInvokeExtensions.cs  # InvokeEx extension for thread‑safe UI updates
│   └── Program.cs                 # Server application entry point
├── WindowsFormsAppClient/         # Client project
│   ├── Form1.cs                   # Main client form and logic
│   ├── ISynchronizeInvokeExtensions.cs  # Same InvokeEx helper
│   └── Program.cs                 # Client application entry point
└── README.md                      # This documentation
```

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
