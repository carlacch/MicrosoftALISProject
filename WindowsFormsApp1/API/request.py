import requests
import json

#Demande d'un résultat à travers l'API
url = 'http://localhost:5001/api/predictNext'

headers = {'content-type': 'text/plain', 'Accept-Charset': 'UTF-8'}
r = requests.post(url, data="besoin de to", headers=headers)
print(r, r.text)