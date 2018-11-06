from PyQt5 import QtWidgets, uic

import json
import requests

##class interface:
##        app = QtWidgets.QApplication([])
##        dlg = uic.loadUi(path)
##        
##        def ACME():
##            dlg.lineEdit_2.setText()
##                
##        
##        def showUI():
##                self.dlg.show()
##                self.app.exec()
##
##        def __init__(self):


class movieApi:
	apiKey = ""
	url = ""
	call = ""

	def __init__(self, key, Url):
		self.apiKey = key
		self.url = Url
		self.call = self.url + self.apiKey

	def queryMovie(self, title):
		response = requests.get(self.call+title)
		a = response.status_code
		t = response.text
		print(a)
		print(self.call+title)
		print(t)
		return t

api = movieApi("3db990c4&", "http://www.omdbapi.com/?apikey=")	

def ACME():
        output = api.queryMovie("t="+"Blade runner")
        dlg.lineEdit_2.setText(output)
         

app = QtWidgets.QApplication([])
dlg = uic.loadUi("ACME.ui")

dlg.pushButton.clicked.connect(ACME)

dlg.show()
app.exec()


#"http://www.omdbapi.com/?i=tt3896198&apikey=3db990c4"
##ui = interface()
##ui.dlg.pushButton.clicked.connect(ui.ACME)
	







