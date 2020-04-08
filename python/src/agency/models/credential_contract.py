# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class CredentialContract(Model):
    """CredentialContract.

    :param credential_id:
    :type credential_id: str
    :param state: Possible values include: 'Offered', 'Requested', 'Issued',
     'Rejected', 'Revoked'
    :type state: str or ~agency.models.enum
    :param connection_id:
    :type connection_id: str
    :param definition_id:
    :type definition_id: str
    :param schema_id:
    :type schema_id: str
    :param offer_data:
    :type offer_data: str
    :param offer_url:
    :type offer_url: str
    :param values:
    :type values: dict[str, str]
    """

    _attribute_map = {
        'credential_id': {'key': 'credentialId', 'type': 'str'},
        'state': {'key': 'state', 'type': 'str'},
        'connection_id': {'key': 'connectionId', 'type': 'str'},
        'definition_id': {'key': 'definitionId', 'type': 'str'},
        'schema_id': {'key': 'schemaId', 'type': 'str'},
        'offer_data': {'key': 'offerData', 'type': 'str'},
        'offer_url': {'key': 'offerUrl', 'type': 'str'},
        'values': {'key': 'values', 'type': '{str}'},
    }

    def __init__(self, **kwargs):
        super(CredentialContract, self).__init__(**kwargs)
        self.credential_id = kwargs.get('credential_id', None)
        self.state = kwargs.get('state', None)
        self.connection_id = kwargs.get('connection_id', None)
        self.definition_id = kwargs.get('definition_id', None)
        self.schema_id = kwargs.get('schema_id', None)
        self.offer_data = kwargs.get('offer_data', None)
        self.offer_url = kwargs.get('offer_url', None)
        self.values = kwargs.get('values', None)