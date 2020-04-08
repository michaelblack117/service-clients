# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class WebhookParameters(Model):
    """WebhookParameters.

    :param url:
    :type url: str
    :param type: Possible values include: 'Notification', 'DelegatedEndorser'
    :type type: str or ~agency.models.enum
    """

    _attribute_map = {
        'url': {'key': 'url', 'type': 'str'},
        'type': {'key': 'type', 'type': 'str'},
    }

    def __init__(self, **kwargs):
        super(WebhookParameters, self).__init__(**kwargs)
        self.url = kwargs.get('url', None)
        self.type = kwargs.get('type', None)