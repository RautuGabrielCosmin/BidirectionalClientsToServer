# C# Windows Forms TCP Client‑Server Application

A GUI‑driven TCP server and client built with Windows Forms, demonstrating real‑time message exchange, multithreading, and safe cross‑thread UI updates.

## Description

This solution includes two WinForms projects:

- **Server** (`WindowsFormsApp`)  
  - Listens on a user‑specified port (default 5000)  
  - Tracks and displays the number of connected clients  
  - Shows incoming client messages in a scrolling log  
  - Lets you broadcast a text command to all connected clients  
  - Cleanly stops the listener and disconnects clients on demand  

- **Client** (`WindowsFormsAppClient`)  
  - Connects to a server IP/port of your choice  
  - Sends a “hello” message on connect and displays server responses in real time  
  - Allows sending text commands to the server  
  - Supports graceful disconnect at any time  

Both apps use a shared `InvokeEx` extension for `ISynchronizeInvoke` to marshal updates onto the UI thread safely.

## Key Features

- **GUI Control**: Start/Stop server and Connect/Disconnect client via buttons  
- **Multithreading**: Dedicated background threads for listening and processing network I/O  
- **Safe UI Updates**: `InvokeEx` extension avoids cross‑thread exceptions when updating controls  
- **Real‑Time Messaging**: Bidirectional command/response workflow between server and clients  
- **Client Management**: Automatic tracking of connected clients with count display  

## Prerequisites

- .NET Framework 4.7.2 (or later)  
- Visual Studio 2019 (or later) with Windows Forms support  

## Setup & Usage

1. **Clone the repository**  
   git clone https://github.com/your-username/csharp-winforms-tcp-chat.git  
   cd csharp-winforms-tcp-chat

2. **Open the solution**  
   Launch `CSharpWinFormsTcpChat.sln` in Visual Studio.

3. **Build the solution**  
   Build → Rebuild Solution

4. **Run the Server**  
   - Right‑click `WindowsFormsApp` → Set as Startup Project  
   - Press F5  
   - Enter a port (e.g. 5000) and click Start Server

5. **Run the Client**  
   - Right‑click `WindowsFormsAppClient` → Set as Startup Project  
   - Press F5  
   - Enter server IP (e.g. 127.0.0.1) and port, click Connect

6. **Chat & Command**  
   - On the client form, type a command and click Send Command  
   - Watch the server log update, and the client receive responses  
   - Use Disconnect on the client or Stop Server on the server to tear down  

## Project Structure

/WindowsFormsApp  
├── Form1.cs                      # Server GUI logic  
├── Form1.Designer.cs             # Server form layout  
└── Utils/ISynchronizeInvokeExtensions.cs  # UI‑thread helper  

/WindowsFormsAppClient  
├── Form1.cs                      # Client GUI logic  
├── Form1.Designer.cs             # Client form layout  
└── Utils/ISynchronizeInvokeExtensions.cs  # UI‑thread helper  

/Program.cs                        # Entry point (if separate)  
/README.md                         # Project documentation  
/LICENSE                           # MIT License  

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
