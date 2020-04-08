# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class VerificationContract(Model):
    """VerificationContract.

    :param connection_id:
    :type connection_id: str
    :param verification_id:
    :type verification_id: str
    :param state: Possible values include: 'Requested', 'Accepted', 'Rejected'
    :type state: str or ~agency.models.enum
    :param created_at_utc:
    :type created_at_utc: datetime
    :param updated_at_utc:
    :type updated_at_utc: datetime
    :param is_valid:
    :type is_valid: bool
    :param verified_at_utc:
    :type verified_at_utc: datetime
    :param proof:
    :type proof: dict[str, ~agency.models.ProofAttributeContract]
    :param verification_request_data:
    :type verification_request_data: str
    :param verification_request_url:
    :type verification_request_url: str
    """

    _attribute_map = {
        'connection_id': {'key': 'connectionId', 'type': 'str'},
        'verification_id': {'key': 'verificationId', 'type': 'str'},
        'state': {'key': 'state', 'type': 'str'},
        'created_at_utc': {'key': 'createdAtUtc', 'type': 'iso-8601'},
        'updated_at_utc': {'key': 'updatedAtUtc', 'type': 'iso-8601'},
        'is_valid': {'key': 'isValid', 'type': 'bool'},
        'verified_at_utc': {'key': 'verifiedAtUtc', 'type': 'iso-8601'},
        'proof': {'key': 'proof', 'type': '{ProofAttributeContract}'},
        'verification_request_data': {'key': 'verificationRequestData', 'type': 'str'},
        'verification_request_url': {'key': 'verificationRequestUrl', 'type': 'str'},
    }

    def __init__(self, **kwargs):
        super(VerificationContract, self).__init__(**kwargs)
        self.connection_id = kwargs.get('connection_id', None)
        self.verification_id = kwargs.get('verification_id', None)
        self.state = kwargs.get('state', None)
        self.created_at_utc = kwargs.get('created_at_utc', None)
        self.updated_at_utc = kwargs.get('updated_at_utc', None)
        self.is_valid = kwargs.get('is_valid', None)
        self.verified_at_utc = kwargs.get('verified_at_utc', None)
        self.proof = kwargs.get('proof', None)
        self.verification_request_data = kwargs.get('verification_request_data', None)
        self.verification_request_url = kwargs.get('verification_request_url', None)
