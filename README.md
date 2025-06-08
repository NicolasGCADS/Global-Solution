## 🌡️ SafeZone - API REST em .NET  
Este projeto é uma Web API desenvolvida em ASP.NET Core, que permite o controle de dispositivos IoT e alertas ambientais com operações básicas de CRUD (Create, Read, Update, Delete). A aplicação segue uma arquitetura em camadas, com separação de responsabilidades entre Model, Business, Data e API.

---

## 🌍 Nome do Projeto: SafeZone  
O projeto SafeZone nasceu da necessidade de monitorar ambientes sensíveis a mudanças climáticas e variações extremas de temperatura e umidade. Ambientes como garagens, espaços industriais ou locais que abrigam populações vulneráveis precisam de uma solução confiável e em tempo real para detectar riscos.

O sistema utiliza sensores conectados a dispositivos IoT, que coletam informações ambientais e as transmitem para uma Web API. Essa API organiza os dados e emite **alertas automáticos** caso os valores ultrapassem os limites seguros.

A interface web, feita com Razor Pages, permite que os usuários visualizem os alertas, dispositivos instalados e os dados de leitura em tempo real. Tudo isso proporciona mais segurança, controle e agilidade na tomada de decisões.

---

## 🔗 Rotas  
🔹 UsuarioController  

| Método | Endpoint               | Descrição                |
|--------|------------------------|--------------------------|
| GET    | /api/usuario           | Lista todos os usuários  |
| GET    | /api/usuario/{id}      | Retorna usuário por ID   |
| POST   | /api/usuario           | Cria um novo usuário     |
| PUT    | /api/usuario/{id}      | Atualiza um usuário      |
| DELETE | /api/usuario/{id}      | Remove um usuário        |

🔹 DispositivoController  

| Método | Endpoint                   | Descrição                     |
|--------|----------------------------|-------------------------------|
| GET    | /api/dispositivo           | Lista todos os dispositivos   |
| GET    | /api/dispositivo/{id}      | Retorna dispositivo por ID    |
| POST   | /api/dispositivo           | Cria um novo dispositivo      |
| PUT    | /api/dispositivo/{id}      | Atualiza um dispositivo       |
| DELETE | /api/dispositivo/{id}      | Remove um dispositivo         |

🔹 LeituraController  

| Método | Endpoint              | Descrição                    |
|--------|-----------------------|------------------------------|
| GET    | /api/leitura          | Lista todas as leituras      |
| GET    | /api/leitura/{id}     | Retorna leitura por ID       |
| POST   | /api/leitura          | Registra uma nova leitura    |
| PUT    | /api/leitura/{id}     | Atualiza uma leitura         |
| DELETE | /api/leitura/{id}     | Remove uma leitura           |

🔹 AlertaController  

| Método | Endpoint             | Descrição                   |
|--------|----------------------|-----------------------------|
| GET    | /api/alerta          | Lista todos os alertas      |
| GET    | /api/alerta/{id}     | Retorna alerta por ID       |
| POST   | /api/alerta          | Cria um novo alerta         |
| PUT    | /api/alerta/{id}     | Atualiza um alerta          |
| DELETE | /api/alerta/{id}     | Remove um alerta            |

---

## 🚀 Tecnologias Utilizadas  
- .NET 8  
- ASP.NET Core Web API  
- Entity Framework Core  
- Oracle  
- Razor Pages  
- Swagger (Swashbuckle)  
- Visual Studio 2022+  
- REST Client (ou Postman)  

---

## 💻 Como Rodar  
1. Git clone https://github.com/NicolasGCADS/Global-Solution.git
2. Selecione a pasta SafeZoneApi e selecione SafeZoneApi.sln para compilar o projeto completo
3. Ao rodar o Crud, rode com HTTPS 
4. Ao rodar o Crud com Swagger, rode com esse link https://localhost:7268/swagger/index.html
5. Ao rodar o Razor, rode com esse link https://localhost:7160

---

## Diagrama 

```mermaid
sequenceDiagram
    participant U as Usuario/Bombeiro
    participant M as Mobile
    participant L as Leitura
    participant D as Dispositivos

    U->>M: Cria Conta
    D-->>L: Capta
    L-->>M: Envia
    M-->>U: Alerta

```
---

## Configure a string de conexão Oracle no appsettings.json:
json

"ConnectionStrings": {
  "DefaultConnection": "User Id=usuario;Password=senha;Data Source=oracle_connection_string"
}


---

## 🧑‍💻 Integrantes do Grupo

Guilherme Romanholi Santos - RM557462

Murilo Capristo - RM556794

Nicolas Guinante Cavalcanti - RM557844
