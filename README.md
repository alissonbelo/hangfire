# Projeto de Estudo: Hangfire em .NET  

Este projeto é um estudo prático sobre o uso do **Hangfire**, uma biblioteca para gerenciamento de tarefas em segundo plano em aplicações .NET, utilizando o **Redis** como banco de dados para persistência.  

## Objetivos  
- Configurar o Hangfire em uma aplicação .NET.  
- Explorar tipos de jobs: agendados, recorrentes, em fila e sob demanda.  
- Implementar persistência de jobs com **Redis**.  
- Utilizar o **Hangfire Dashboard** para monitoramento.  

## Tecnologias Utilizadas  
- **.NET 8**  
- **Hangfire**  
- **Redis**  
- **Docker**  

## Funcionalidades  
- **Jobs Agendados**: Configuração de tarefas para horários específicos.  
- **Jobs Recorrentes**: Execução em intervalos regulares.  
- **Jobs em Fila**: Processamento assíncrono com controle de ordem.  
- **Dashboard**: Monitoramento e gerenciamento de tarefas.  

## Pré-requisitos  
Certifique-se de que o Docker está instalado em sua máquina.  

### Rodando o Redis  
Execute o comando abaixo para inicializar o Redis com o Docker:  
```bash  
docker run -d -p 6379:6379 -i -t redis  
```  

## Como Rodar o Projeto  
1. Clone o repositório:  
   ```bash  
   git clone https://github.com/seu-usuario/hangfire-estudo.git
   ```  
2. Acesse o diretório do projeto:  
   ```bash  
   cd hangfire-estudo  
   ```   
3. Restaure os pacotes:  
   ```bash  
   dotnet restore  
   ```  
4. Execute o projeto:  
   ```bash  
   dotnet run  
   ```  
5. Acesse o Hangfire Dashboard:  
   - URL padrão: `http://localhost:5000/hangfire`  

## Contribuição  
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.  

## Licença  
Este projeto é apenas para fins de estudo e não possui licença específica.  

---  
