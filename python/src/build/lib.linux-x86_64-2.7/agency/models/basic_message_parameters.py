# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class BasicMessageParameters(Model):
    """BasicMessageParameters.

    :param connection_id:
    :type connection_id: str
    :param text:
    :type text: str
    """

    _attribute_map = {
        'connection_id': {'key': 'connectionId', 'type': 'str'},
        'text': {'key': 'text', 'type': 'str'},
    }

    def __init__(self, **kwargs):
        super(BasicMessageParameters, self).__init__(**kwargs)
        self.connection_id = kwargs.get('connection_id', None)
        self.text = kwargs.get('text', None)