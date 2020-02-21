## Week 4 - Azure Storage - List the blobs in the container

### Azure CLI - through PowerShell
```powershell
az login
$env:AZURE_STORAGE_ACCOUNT="<account-name>"
$env:AZURE_STORAGE_KEY="<account-key>"
az storage blob list --container-name pictures --output table
```


### .NET SDK