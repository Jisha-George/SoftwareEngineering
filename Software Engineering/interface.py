from PyQt5 import QtWidgets, uic

def ACME():
    dlg.lineEdit_2.setText(str(float(dlg.lineEdit.text())*1.23))
         

app = QtWidgets.QApplication([])
dlg = uic.loadUi("ACME.ui")

dlg.pushButton.clicked.connect(ACME)

dlg.show()
app.exec()
