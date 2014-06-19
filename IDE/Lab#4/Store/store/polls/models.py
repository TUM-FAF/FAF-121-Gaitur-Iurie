from django.db import models

# Create your models here.

class Item(models.Model):
    name = models.CharField(max_length=30, verbose_name="Name product")
    price = models.IntegerField(default=0, verbose_name="Price product")
    description = models.TextField(verbose_name="Description product")
