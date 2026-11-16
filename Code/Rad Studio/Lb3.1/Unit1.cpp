//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "Unit2.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
/*Button1->Font->Size = Form2->ShowModal();
Button1->Caption = Form2->ModalResult;
//Caption = "Dialog finished";*/
//set the current param values

	Form2->Label4->Font->Size = Label1->Font->Size;
	Form2->Label4->Font->Color = Label1->Font->Color;
	if(Form2->ShowModal()==mrOk)
	{
		Label1->Font->Size = Form2->Label4->Font->Size;
		Label1->Font->Color = Form2->Label4->Font->Color;
	};
}
//------------------------------------------------------	 ---------------------
