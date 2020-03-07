#!/bin/bash

npm install -g autorest;
autorest --python --input-file=openapi/custodian.json --add-credentials --output-folder=python/custodian --override-client-name=CustodianClient --custom-service-client-options=[baseUri='https://api.streetcred.id/'] 
