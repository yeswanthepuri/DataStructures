# step 1 - Install donet SDK
sudo apt-get install dotnet-sdk-8.0
sudo apt-get install dotnet-runtime-8.0
sudo apt-get install aspnetcore-runtime-8.0

## Check if installation is successiful
donet --info
# step 2 - Install Nginx
sudo apt-get install nginx

# step 3 Set Up Nginx as reverse proxey
sudo nano /etc/nginx/sites-available/default
## Make this in the above file if you have multiple locations pls dont worry. Make sure to remove any 
*** 
server {  
#Listen on port 80, the default HTTP port
    server_name marthand.in;  # The server name, here it is set to localhost

    root /var/www/html;  # The root directory where files are served from
    index index.html index.htm;  # The default files to serve

    location / {
        limit_req zone=mylimit burst=20 nodelay;
       # try_files $uri $uri/ =404;  # Try to serve the requested URI, if not found return a 404

        }
    location /api/ {
        proxy_pass http://localhost:5000/;   # The URL where your .NET Core API is running
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection keep-alive;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto $scheme;
        proxy_cache_bypass $http_upgrade;
    }

    listen 443 ssl; # managed by Certbot
    ssl_certificate /etc/letsencrypt/live/marthand.in/fullchain.pem; # managed by Certbot
    ssl_certificate_key /etc/letsencrypt/live/marthand.in/privkey.pem; # managed by Certbot
    }
**
---

# step 4 
Create a Dotnet Web app
#### Remove redirecthttps on the code as weare using reverse proxey

# Step 5 
Install Win SRC if you dont have it. So it makes your life easy to copy files from local to server

# Step 6 Create a Folder under the folder and copy the files to the folder and give the permissions to the user

sudo mkdir /var/www/app
sudo chmod 777 app
sudo chown epuri app
cd /var/www/app
# step 7: Test the project

sudo dotnet projectname.dll 
#### ex: sudo dotnet MarthandBackend.dll, By now the URL will be accessable

# step 7 Create a Service File

sudo nano /etc/systemd/system/MarthandBackend.service

#### Copy this code in that file

> [Unit]
> Description=MarthandAppTest
>
> [Service]
> WorkingDirectory=/var/www/app/
> ExecStart=/usr/bin/dotnet /var/www/app/MarthandBackend.dll
> Restart=always
> #Restart service after 10 seconds if the dotnet service crashes:
> RestartSec=10
> KillSignal=SIGINT
> SyslogIdentifier=dotnet-LinuxWebAppTest
> User=root
> Environment=ASPNETCORE_ENVIRONMENT=Production
> Environment=DOTNET_PRINT_TELEMETRY_MESSAGE=false
> 
> [Install]
> WantedBy=multi-user.target

##### Run the below command
sudo systemctl enable MarthandBackend.service
sudo systemctl start MarthandBackend.service
sudo nginx -s reload