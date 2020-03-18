# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class ConnectionContract(Model):
    """ConnectionContract.

    :param connection_id:
    :type connection_id: str
    :param name:
    :type name: str
    :param image_url:
    :type image_url: str
    :param my_did:
    :type my_did: str
    :param their_did:
    :type their_did: str
    :param my_key:
    :type my_key: str
    :param their_key:
    :type their_key: str
    :param state: Possible values include: 'Invited', 'Negotiating',
     'Connected'
    :type state: str or ~custodian.models.enum
    :param invitation:
    :type invitation: str
    :param invitation_url:
    :type invitation_url: str
    :param endpoint:
    :type endpoint: ~custodian.models.AgentEndpoint
    :param created_at_utc:
    :type created_at_utc: datetime
    """

    _attribute_map = {
        'connection_id': {'key': 'connectionId', 'type': 'str'},
        'name': {'key': 'name', 'type': 'str'},
        'image_url': {'key': 'imageUrl', 'type': 'str'},
        'my_did': {'key': 'myDid', 'type': 'str'},
        'their_did': {'key': 'theirDid', 'type': 'str'},
        'my_key': {'key': 'myKey', 'type': 'str'},
        'their_key': {'key': 'theirKey', 'type': 'str'},
        'state': {'key': 'state', 'type': 'str'},
        'invitation': {'key': 'invitation', 'type': 'str'},
        'invitation_url': {'key': 'invitationUrl', 'type': 'str'},
        'endpoint': {'key': 'endpoint', 'type': 'AgentEndpoint'},
        'created_at_utc': {'key': 'createdAtUtc', 'type': 'iso-8601'},
    }

    def __init__(self, *, connection_id: str=None, name: str=None, image_url: str=None, my_did: str=None, their_did: str=None, my_key: str=None, their_key: str=None, state=None, invitation: str=None, invitation_url: str=None, endpoint=None, created_at_utc=None, **kwargs) -> None:
        super(ConnectionContract, self).__init__(**kwargs)
        self.connection_id = connection_id
        self.name = name
        self.image_url = image_url
        self.my_did = my_did
        self.their_did = their_did
        self.my_key = my_key
        self.their_key = their_key
        self.state = state
        self.invitation = invitation
        self.invitation_url = invitation_url
        self.endpoint = endpoint
        self.created_at_utc = created_at_utc
