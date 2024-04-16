<b>Routes:</b>

<i>Cars:</i> <br>
<span style="color:cyan">[GET | POST]</span> => .../car <br>
<span style="color:cyan">[GET | PATCH | DELETE]</span> => .../car/{id}

<i>Customers:</i> <br>
<span style="color:cyan">[GET | POST]</span> => .../customer <br>
<span style="color:cyan">[GET | PATCH | DELETE]</span> => .../customer/{id}

<i>Agreements:</i> <br>
<span style="color:cyan">[GET | POST]</span> => .../agreement <br>
<span style="color:cyan">[GET | PATCH | DELETE]</span> => .../agreement/{agreementID} <br>
<span style="color:cyan">[GET | PATCH | DELETE]</span> => .../agreement/{agreementID}/car <br>
<span style="color:cyan">[GET | PATCH | DELETE]</span> => .../agreement/{agreementID}/customer <br>
<span style="color:cyan">[GET | POST | PATCH | DELETE]</span> => .../agreement/car <br>
<span style="color:cyan">[GET | POST | PATCH | DELETE]</span> => .../agreement/customer <br>
<span style="color:cyan">[GET | POST | PATCH | DELETE]</span> => .../agreement/car/{carID} <br>
<span style="color:cyan">[GET | POST | PATCH | DELETE]</span> => .../agreement/customer/{customerID}