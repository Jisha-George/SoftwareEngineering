from selenium import webdriver
import sys
import os
import time

driver = webdriver.Chrome()
driver.implicitly_wait(15) # wait's for the page to get done
driver.get('http://www.google.com/')
# to fill out a form
search = driver.find_element_by_name('q')
search.send_keys('blade runner')
search.submit()
time.sleep(5)
print(br.title)
