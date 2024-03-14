from flask import Flask, render_template
from regForm import RegisterForm


app = Flask(__name__)
app.config['SECRET_KEY'] = "hello hello hello hello"


@app.route("/register", methods=["GET", "POST"])
def register():
    form = RegisterForm()
    if form.validate_on_submit():
        print(form.data['name'], 
              form.data['email'],
              form.data['password'])
    return render_template("reg.html", form=form)


@app.route("/") # GET
def index():
    return render_template('base.html')
    # ./temapltes/base.html


@app.route("/calc/<int:x>/<int:y>") # по умолчанию тип данных string #79 символов
def sum(x, y):
    return f'{x} + {y} = {x + y}<br>{x} - {y} = {x - y}<br>{x} * {y} = {x * y}<br>{x} / {y} = {x / y}'


@app.route("/stud_online")
def list_students():
    data = ["Азер Агазаде", "Святослав Мариничев",
            "Алина Патейчук", "Ольга Шенкель",
            "Алексей Красько", "Всеволод Харламенко",
            "Сергей Силькунов", "Дмитрий Захаров"] # list           
    return render_template("students.html", data=data,
                           title="Список студентов" )


if __name__ == '__main__':
    app.run()
    # app.run(port=8000)
