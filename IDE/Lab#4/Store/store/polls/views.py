from django.shortcuts import render
from django.http import HttpResponse
from django.template import Context,loader


def index(request):
    return HttpResponse("Here is my layer")


def me(request):

    return HttpResponse(render(request, 'me.html', content_type="application/xhtml+xml"))


def store(request, slug=None):
    if slug is not None:
        return HttpResponse("Here is my shop")

    t = loader.get_template('me.html')

    return HttpResponse(render(request, 'index.html', content_type="application/xhtml+xml"))