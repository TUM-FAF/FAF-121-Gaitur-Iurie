from django.conf.urls import patterns, include, url
from django.views.generic.base import TemplateView
from django.contrib import admin
admin.autodiscover()



urlpatterns = patterns('',
    url(r'^admin/', include(admin.site.urls)),
    url(r'^$', 'polls.views.index'),
     # ex: /polls/5/results/
    url(r'^me/$', 'polls.views.me'),
    # ex: /polls/5/vote/
    url(r'^store/(?P<item>[0-9]+)/$', 'polls.views.store'),
    url(r'^store/$', 'polls.views.store'),
    # url(r'^blog/', include('blog.urls')),


    #url(r'^$', 'store.views.index', name='index'),
    #url(r'^$', 'store.views.me', name='me'),
)
