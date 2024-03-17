# Django

## Requirements

- Python
- PIP
- Virtual Environment

### Virtual Environment

```bash
$ python -m venv myworld # Creates the virtual environment
$ source myworld/bin/activate # Activates the virtual environment
```

### Install Django

```bash
(myworld) $ python -m pip install Django # Install Django from pip
(myworld) $ django-admin --version # Check if Django is install on the virtual environment
```
### Create Project

```bash
(myworld) $ django-admin startproject my_tennis_club # Creates my_tennis_club project.
(myworld) $ python manage.py runserver # Run Django live-server.
```

### Create App

```bash
(myworld) $ cd my_tennis_club
(myworld) $ python manage.py startapp members # Creates Django app
```

### Django Views

Edit `my_tennis_club/members/views.py` :

```python
from django.shortcuts import render
from django.http import HttpResponse

def members(request):
    return HttpResponse("Hello world!")
```

### Django URLs

```bash
(myworld) $ touch my_tennis_club/members/urls.py # Creates urls.py file.
```

Edit `my_tennis_club/members/urls.py` : 

```python
from django.urls import path
from . import views

urlpatterns = [
    path('members/', views.members, name='members'),
]

```

Edit `my_tennis_club/my_tennis_club/urls.py` :

```python
from django.contrib import admin
from django.urls import include, path

urlpatterns = [
    path('', include('members.urls')),
    path('admin/', admin.site.urls),
]
```

```bash
(myworld) $ python manage.py runserver # Test the changes you made
```

### Templates

```bash
(myworld) $ mkdir -p my_tennis_club/members/templates && touch my_tennis_club/members/templates/index.html
```

Edit `my_tennis_club/members/templates/index.html` :

```html
<!DOCTYPE html>
<html>
<body>

<h1>Hello World!</h1>
<p>Welcome to my first Django project!</p>

</body>
</html>
```

Edit `my_tennis_club/members/views.py` :

```python
from django.http import HttpResponse
from django.template import loader

def members(request):
  template = loader.get_template('index.html')
  return HttpResponse(template.render())
```

Edit `my_tennis_club/my_tennis_club/settings.py` :

```python
INSTALLED_APPS = [
    ...
    ...
    'members',
]
```

```bash
(myworld) $ python manage.py runserver
```