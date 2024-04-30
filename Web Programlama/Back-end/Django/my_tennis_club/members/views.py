from django.http import HttpResponse
from django.template import loader
from .models import Member

def members(request):
    template = loader.get_template('index.html')
    return HttpResponse(template.render())
    context = {
        'mymembers': mymembers,
    }
    return HttpResponse(template.render(context, request))
