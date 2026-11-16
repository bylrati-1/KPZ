//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.Menus.hpp>
#include <Vcl.OleCtnrs.hpp>
#include <Vcl.Dialogs.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TOleContainer *OleContainer1;
	TMainMenu *MainMenu1;
	TMenuItem *Object1;
	TMenuItem *Object2;
	TMenuItem *Destroy1;
	TMenuItem *FromFile1;
	TOpenDialog *OpenDialog1;
	TMenuItem *File1;
	TMenuItem *File2;
	TMenuItem *SaveAs1;
	TMenuItem *Open1;
	TSaveDialog *SaveDialog1;
	TMenuItem *CreateObject1;
	void __fastcall Object2Click(TObject *Sender);
	void __fastcall Destroy1Click(TObject *Sender);
	void __fastcall FromFile1Click(TObject *Sender);
	void __fastcall File2Click(TObject *Sender);
	void __fastcall Open1Click(TObject *Sender);
	void __fastcall SaveAs1Click(TObject *Sender);
	void __fastcall CreateObject1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
